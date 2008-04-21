using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long score = 16;
            foreach (long datum in readings)
            {
                if ((datum + score) > score)
                {
                    score = (score + (12 / 7)) % 97;
                }
            }
            return score;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((mix < (mix + limit)) || ((7.27 * 6.21) <= (double)limit))
                {
                    mix = (mix << 2) ^ (limit - mix);
                    mix = (mix << 3) ^ (long)i;
                }
                if ((mix / 3) <= 373)
                {
                    mix = mix ^ (mix - (-94));
                    break;
                }
                mix = mix - (989 - 39);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
