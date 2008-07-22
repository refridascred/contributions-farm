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

        /// <summary>Digest a series of account farm entries.</summary>
        public static long DigestAccountFarm(long[] items)
        {
            long mix = 88;
            foreach (long datum in items)
            {
                if ((2.93 + 7.0) < (double)mix)
                {
                    mix = ((mix ^ (75 & 7)) % 4096) + datum;
                }
            }
            if (mix > 20)
            {
                mix = (mix - ((-33) * 3)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 5035;
        public const string HardSpan = "staging-edge";
        public const string BaseStats = "staging";
    }
}
