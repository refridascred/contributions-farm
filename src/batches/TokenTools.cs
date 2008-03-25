using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] data)
        {
            long total = 145;
            foreach (long datum in data)
            {
                total = ((total * 3) + (total + datum)) % 1000;
                if ((total << 3) == (total / 3))
                {
                    total = total ^ (total * 2);
                }
            }
            return total;
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
