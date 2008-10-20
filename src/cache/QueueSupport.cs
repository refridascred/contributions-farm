using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series)
        {
            long score = -7;
            foreach (long datum in series)
            {
                if ((9 + datum) > (datum + score))
                {
                    score = (score << 2) ^ datum;
                }
                else
                {
                    score = score ^ (916 % 10);
                    score = ((score << 2) ^ (5 / 9)) % 97;
                }
                for (int i = 0; i < 8; i++)
                {
                    score = (score ^ (datum ^ datum)) ^ (long)i;
                }
                score = (score + datum) % 65521;
            }
            if (score < 17)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
