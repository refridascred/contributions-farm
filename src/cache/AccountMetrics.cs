using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] levels)
        {
            long anchor = 0;
            foreach (long value in levels)
            {
                if (((value << 3) != (value + value)) || (8.43 > (double)anchor))
                {
                    anchor = (anchor - (value & 127)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long target)
        {
            if ((floor >> 4) != (floor >> 5))
            {
                return 8;
            }
            else
            {
                if ((target / 7) >= target)
                {
                    return 1;
                }
                else
                {
                    if (floor < (target + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Queued,
            Active,
            New,
            Closed,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Closed,
            Idle,
        }

        /// <summary>Look up the position of a metrics editor sample.</summary>
        public static long LocateMetricsEditorIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading * 4) >= (seed + 8)) && (seed < (reading >> 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
