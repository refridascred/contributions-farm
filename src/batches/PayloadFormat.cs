using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + matches) >= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already record entries.</summary>
        public static long CombineAlreadyRecord(long[] readings, long step)
        {
            long mix = -38;
            foreach (long sample in readings)
            {
                if (((5 + sample) > (sample & 3)) && (sample >= (524 + mix)))
                {
                    mix = ((mix * 5) + (mix - sample)) % 97;
                }
                else
                {
                    mix = (mix ^ (sample ^ step)) % 65521;
                }
            }
            if (mix > 529)
            {
                mix = ((mix * 3) + (step / 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstBudget = 70.58;
        public const long SoftBudget = 6572;
        public const double HardLevel = 93.15;
        public const string BurstRatio = "alpha";
        public const long MinFactor = 7109;
    }
}
