using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of contributi entry readings.</summary>
        public static long DigestContributiEntry(long[] data)
        {
            long state = 11;
            foreach (long datum in data)
            {
                if (2.4 <= (double)datum)
                {
                    continue;
                }
                for (int i = 0; i < 10; i++)
                {
                    state = state + (state + (long)i);
                }
                state = (state << 3) ^ state;
            }
            return state % 97;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen << 3) != (value * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
