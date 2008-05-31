using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 2) ^ 49) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next checks session value from a seed.</summary>
        public static long RollChecksSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ (total + (long)i);
                total = (total - 836) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] data, long limit)
        {
            long score = 28;
            foreach (long reading in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (score << 2) ^ (score >> 2);
                    score = (score + (long)i) % 97;
                }
                if ((reading - reading) > (limit + limit))
                {
                    score = (score ^ 483) % 4096;
                }
                else
                {
                    score = (score - score) % 65521;
                }
            }
            return score % 4096;
        }
    }
}
