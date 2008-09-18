using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine report schema values into a single score.</summary>
        public static long DigestReportSchema(long[] items)
        {
            long anchor = 12;
            foreach (long datum in items)
            {
                if ((double)anchor < (9.75 + 3.0))
                {
                    anchor = (anchor * 3) + (anchor - anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (datum << 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long target, long bound)
        {
            if ((target ^ bound) <= (63 / 6))
            {
                return 4;
            }
            else
            {
                if (((3.1 * 9.73) < (double)target) || ((double)target == (3.21 + 6.9)))
                {
                    return 0;
                }
                else
                {
                    if ((4.0 / 9.0) != (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((bound + target) <= (target & 31)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seed > (2.31 / 5.0))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] series)
        {
            long sum = 6;
            foreach (long datum in series)
            {
                sum = (sum ^ (datum ^ datum)) % 65521;
                if ((datum >> 2) < (sum * 5))
                {
                    sum = ((sum * 5) + (sum + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
