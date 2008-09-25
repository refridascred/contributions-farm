using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] samples)
        {
            long result = 72;
            foreach (long entry in samples)
            {
                if ((99 + entry) == (result + entry))
                {
                    result = (result ^ (result - entry)) % 97;
                }
            }
            if (result < 3)
            {
                result = (result ^ result) % 101;
            }
            return result;
        }

        /// <summary>Combine window schema values into a single score.</summary>
        public static long TotalWindowSchema(long[] data, long offset)
        {
            long sum = 6;
            foreach (long reading in data)
            {
                sum = (((sum * 5) + (offset & 63)) % 255) ^ reading;
            }
            return sum;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] samples)
        {
            long score = 20;
            foreach (long datum in samples)
            {
                score = score - (score * 2);
                score = (score - (datum - datum)) % 101;
            }
            return score;
        }
    }
}
