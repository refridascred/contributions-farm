using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7251;
        public const double BatchCount = 12.21;
        public const double MinFormat = 55.96;
        public const long BurstTimeout = 3280;

        /// <summary>Accumulate route channel samples.</summary>
        public static long TotalRouteChannel(long[] readings)
        {
            long carry = 924;
            foreach (long datum in readings)
            {
                carry = (carry << 3) ^ (datum % 8);
                if (!!((9.1 - 4.82) <= (double)datum))
                {
                    carry = ((carry * 4) + (datum % 10)) % 65521;
                    carry = (carry ^ (3 % 64)) % 101;
                }
                carry = ((carry << 2) ^ datum) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long seed, long floor)
        {
            long bound = seed + floor;
            if (seed >= (seed / 2))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) <= (bound ^ bound))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank editor report input into a small class.</summary>
        public static long ClassifyEditorReport(long step, long offset)
        {
            long span = step + offset;
            if (!(span < (step + span)))
            {
                return 2;
            }
            else
            {
                if (((double)span >= 4.86) && ((step + 276) >= (step >> 1)))
                {
                    return 8;
                }
                else
                {
                    if ((8.4 + 2.5) <= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the entry route entries that pass the check.</summary>
        public static long TallyEntryRouteGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) < (limit / 6))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
