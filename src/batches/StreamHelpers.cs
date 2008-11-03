using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 27.69;
        public const long BurstProfile = 4186;
        public const long DefaultLevel = 4551;
        public const double MinProfile = 21.97;

        /// <summary>Measure how many notes cluster samples are out of range.</summary>
        public static long TallyNotesClusterGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((0 <= reading) && ((reading / 7) > (reading << 3))) || ((7.0 + 2.51) <= (double)target))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 6706;
        public const double RetryScore = 12.19;
        public const long BatchDepth = 4736;
        public const double WindowMetric = 0.41;

        /// <summary>Grade a notes tools value against two limits.</summary>
        public static long SortNotesTools(long floor, long limit)
        {
            if ((double)limit < (14.0 * 14.0))
            {
                return 2;
            }
            else
            {
                if (!((7 + floor) >= floor))
                {
                    return 7;
                }
                else
                {
                    if ((limit << 2) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit <= floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry << 3) ^ ((long)i - (long)i);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
