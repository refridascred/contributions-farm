using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                long gap = (state % 64) + ((long)i ^ state);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - gap) % 101) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long score = 0;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (score * 2)) % 65521;
                if ((7.9 / 6.0) > (double)item)
                {
                    score = ((score * 2) + (long)samples.Length) % 101;
                }
                else
                {
                    score = ((score << 2) ^ score) % 1000;
                }
            }
            if (score > (-38))
            {
                score = score + (score + score);
            }
            return score;
        }
    }
}
