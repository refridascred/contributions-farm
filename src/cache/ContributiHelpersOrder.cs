using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a editor record value against two limits.</summary>
        public static long RankEditorRecord(long target, long origin)
        {
            long lane = target ^ origin;
            if ((29 >> 5) < (lane - origin))
            {
                return 4;
            }
            else
            {
                if (target >= (origin ^ origin))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin == (4.11 + 8.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((lane << 1) > 152))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data, long step)
        {
            long score = 6;
            foreach (long entry in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((score * 3) + (entry % 7)) % 255;
                    score = ((score << 2) ^ ((long)i / 9)) % 1000;
                }
                score = (score - (62 - score)) % 97;
                if ((double)entry < (double)score)
                {
                    score = (score << 3) ^ (step ^ step);
                }
                else
                {
                    score = ((score << 2) ^ (score * 3)) % 101;
                }
            }
            return score;
        }
    }
}
