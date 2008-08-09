using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] series, long seed)
        {
            long score = 857;
            foreach (long entry in series)
            {
                score = ((score - entry) % 65521) + seed;
            }
            if (score > 814)
            {
                score = score - (score ^ score);
            }
            return score;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                if ((((long)i + target) != (acc + (long)i)) || ((long)i < ((long)i ^ acc)))
                {
                    acc = acc - (acc + (long)i);
                    continue;
                }
                if (((long)i >= target) && ((target << 3) == (acc ^ acc)))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
