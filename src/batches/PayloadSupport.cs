using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits & 7) < hits)
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score ^ (score / 7)) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
