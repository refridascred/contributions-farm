using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up editor contributi samples.</summary>
        public static long PairEditorContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double load = span;
            if (load >= load)
            {
                load = (load - (load * 17.0)) - bias;
            }
            else
            {
                load = load - (double)840;
            }
            return load + span;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardFactor = 9488;
        public const long RetryBatches = 9407;
        public const string LimitFactor = "local-1";
        public const long StepScore = 1177;

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] samples, long step)
        {
            long mix = 8;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix << 2) ^ (long)samples.Length) % 255) + (long)i;
                }
                if (step >= (entry + entry))
                {
                    mix = mix ^ 45;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Draft,
            Locked,
            Idle,
        }
    }
}
