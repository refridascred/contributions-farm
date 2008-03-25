using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) < tally)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if ((543 - step) <= (61 + result))
                {
                    result = result - (step + 633);
                    break;
                }
                result = (result - result) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Locked,
            Dropped,
            Stale,
        }
    }
}
