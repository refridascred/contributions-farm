using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of already tools readings.</summary>
        public static long CompareAlreadyToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] series)
        {
            long total = 1;
            foreach (long entry in series)
            {
                total = ((total + (total / 6)) % 65521) + entry;
            }
            return total;
        }

        /// <summary>Combine context filter values into a single score.</summary>
        public static long WeighContextFilter(long[] items)
        {
            long score = 27;
            foreach (long entry in items)
            {
                score = ((score * 3) + (score - (-2))) + entry;
            }
            if (score < 3)
            {
                score = (score - (73 % 10)) % 4096;
            }
            return score;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Queued,
            Ready,
        }
    }
}
