using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = mark + (mark + (long)i);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
