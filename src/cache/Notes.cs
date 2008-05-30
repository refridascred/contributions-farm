using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long floor)
        {
            if ((double)floor <= 4.1)
            {
                return 6;
            }
            else
            {
                if (((2.07 + 15.0) < (double)target) || ((target / 5) >= (floor >> 3)))
                {
                    return 8;
                }
                else
                {
                    if (9.0 >= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix ^ (mix + (long)i)) % 255;
                mix = ((mix << 2) ^ (long)i) % 4096;
                if (((long)i + (long)i) != (mix >> 4))
                {
                    mix = (mix ^ (49 / 5)) % 101;
                    mix = (mix * 3) + (offset / 9);
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long limit)
        {
            long diff = floor ^ limit;
            if (diff > floor)
            {
                return 8;
            }
            else
            {
                if (((diff << 3) != (floor + diff)) || ((8 ^ floor) >= floor))
                {
                    return 0;
                }
                else
                {
                    if ((17 / 4) == (limit + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Locked,
            Queued,
            Draft,
            New,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches % 8) <= (matches << 1))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }
    }
}
