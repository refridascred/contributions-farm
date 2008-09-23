using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of support filter readings.</summary>
        public static long DigestSupportFilter(long[] items)
        {
            long total = 686;
            foreach (long sample in items)
            {
                if (!((sample - total) > (total % 100)))
                {
                    total = (total ^ 825) % 97;
                }
            }
            return total;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = score + score;
                if ((step - step) <= (score - step))
                {
                    score = ((score * 2) + (step / 4)) % 4096;
                }
                else
                {
                    score = score - 809;
                    score = ((score * 4) + ((long)i / 3)) % 65521;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
