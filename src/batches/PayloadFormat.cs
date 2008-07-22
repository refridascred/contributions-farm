using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long seed, long floor)
        {
            long bound = seed - floor;
            if ((bound + seed) < (floor % 7))
            {
                return 6;
            }
            else
            {
                if ((floor + seed) > (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor + bound) >= (seed + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed >= (4 ^ seed)) || ((3.89 / 7.0) != (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 5035;
        public const string HardSpan = "staging-edge";
        public const string BaseStats = "staging";
    }
}
