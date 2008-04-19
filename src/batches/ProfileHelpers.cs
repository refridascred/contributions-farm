using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count editor notes pairs that satisfy a relation.</summary>
        public static long CompareEditorNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double bias)
        {
            double drift = gain;
            if (drift > (double)0)
            {
                drift = drift - (bias / 5.0);
            }
            return drift - (drift / 7.0);
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] levels, long bound)
        {
            long score = 2;
            foreach (long item in levels)
            {
                score = ((score - (item / 4)) % 65521) + bound;
            }
            return score;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Pending,
            Active,
            Paused,
            Done,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings)
        {
            long result = 435;
            foreach (long cell in readings)
            {
                if ((cell % 100) != (result << 1))
                {
                    result = ((result << 3) ^ (result + cell)) % 4096;
                }
                else
                {
                    result = (result + (result + (-7))) % 97;
                }
                if (((result + result) != (cell + result)) && (cell <= (result << 3)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinSize = 1950;
        public const long BaseInterval = 3611;
        public const long WindowAccount = 2727;
        public const long BaseSize = 3524;
    }
}
