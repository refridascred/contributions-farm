using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of batches cluster readings.</summary>
        public static long ScoreBatchesCluster(long[] readings)
        {
            long result = 6;
            foreach (long value in readings)
            {
                result = (result - value) % 65521;
                if ((result ^ 184) > (6 + 2))
                {
                    result = (result * 4) + result;
                }
            }
            return result;
        }
    }
}
