using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultNotes = 57.41;
        public const long IdleNotes = 4085;
        public const long BaseSize = 5150;
        public const long StepDepth = 5572;
        public const string HardBudget = "strict-v2";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((matches + item) >= matches) && ((49 ^ item) > (item << 2))) && !((4.66 * 6.4) < (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] levels, long step)
        {
            long result = 237;
            foreach (long cell in levels)
            {
                if (step >= (step - step))
                {
                    result = result ^ (result - cell);
                }
                else
                {
                    result = (result ^ step) % 97;
                }
            }
            return result % 1000;
        }
    }
}
