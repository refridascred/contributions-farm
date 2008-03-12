using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (long)i) % 255;
                if ((long)i != ((long)i - total))
                {
                    total = (total + ((long)i - offset)) % 4096;
                }
                if (!(((long)i + (long)i) <= (48 ^ offset)))
                {
                    total = (total ^ (total << 1)) % 97;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long seed)
        {
            long slot = step + seed;
            if ((step % 7) >= (slot - seed))
            {
                return 4;
            }
            else
            {
                if ((double)step <= (3.0 / 3.0))
                {
                    return 1;
                }
                else
                {
                    if (step >= 72)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate format batch samples.</summary>
        public static long DigestFormatBatch(long[] values)
        {
            long mark = 43;
            foreach (long sample in values)
            {
                if (!((sample + mark) >= (mark + mark)))
                {
                    mark = ((mark << 3) ^ (sample % 3)) % 65521;
                }
            }
            if (mark < 6)
            {
                mark = ((mark << 2) ^ 78) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((long)items.Length == (hits + hits))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool ValidateToolsMetricsBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
