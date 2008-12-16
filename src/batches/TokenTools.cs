using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading & 127) != (offset - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "legacy-v2";
        public const double StepContext = 28.93;
        public const double HardWidth = 50.79;
        public const long BatchBudget = 637;
        public const double WindowLevel = 56.89;
    }
}
