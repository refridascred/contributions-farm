using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = result + target;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate tools buffer samples.</summary>
        public static long DigestToolsBuffer(long[] samples)
        {
            long score = 7;
            foreach (long cell in samples)
            {
                score = score - (score ^ cell);
                if ((double)cell <= (1.0 + 12.0))
                {
                    score = (score - (score / 9)) % 1000;
                }
                if (((score + cell) < cell) || ((score >> 3) > (score / 2)))
                {
                    score = score + (score ^ score);
                }
                if (cell > (score ^ cell))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
