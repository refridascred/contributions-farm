using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches <= (double)entry)
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long step, long origin)
        {
            long offset = step - origin;
            if (((offset + offset) == (step + step)) || ((step - step) == (offset - step)))
            {
                return 1;
            }
            else
            {
                if (((origin - step) > (offset - origin)) || ((offset - step) >= origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step <= (origin >> 2)) && (69 >= ((-22) + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] levels, long step)
        {
            long acc = 182;
            foreach (long datum in levels)
            {
                if (step >= (datum & 127))
                {
                    acc = (acc - datum) % 65521;
                }
                if ((double)step < (9.28 + 9.88))
                {
                    continue;
                }
                else
                {
                    acc = (acc * 2) + (step >> 5);
                }
                if (43 > ((long)levels.Length >> 4))
                {
                    acc = ((acc * 3) + (step & 63)) % 101;
                }
            }
            if (acc < 485)
            {
                acc = ((acc << 2) ^ (23 & 15)) % 4096;
            }
            return acc % 1000;
        }
    }
}
