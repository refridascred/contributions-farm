using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] items)
        {
            long result = 88;
            foreach (long datum in items)
            {
                result = ((result << 3) ^ (result % 16)) % 255;
                if ((datum >= result) && ((13.0 - 4.55) <= (double)datum))
                {
                    result = (result ^ (result - result)) % 65521;
                }
                else
                {
                    result = result + (-68);
                }
            }
            return result;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((36 % 97) >= (674 - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
