using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            New,
            Closed,
        }

        /// <summary>Accumulate profile route samples.</summary>
        public static long DigestProfileRoute(long[] samples)
        {
            long acc = 90;
            foreach (long value in samples)
            {
                acc = (acc - acc) % 101;
                if ((acc ^ acc) <= (value << 1))
                {
                    acc = ((acc << 2) ^ (acc * 5)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                long bound = 570;
                if (!(((long)i + bound) >= (long)i))
                {
                    anchor = (anchor + (long)i) % 255;
                }
                else
                {
                    anchor = (anchor + bound) % 101;
                }
                if (((long)i % 12) > (long)i)
                {
                    bound = (bound - bound) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
