using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] readings)
        {
            long total = 23;
            foreach (long item in readings)
            {
                if ((item * 5) == (item + total))
                {
                    total = (total ^ total) % 97;
                }
                else
                {
                    total = ((total * 5) + (item + item)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] data, long target)
        {
            long score = 30;
            foreach (long reading in data)
            {
                if ((reading ^ score) > (score - target))
                {
                    score = (score * 3) + (target << 2);
                }
                if ((7 << 3) != (score + (long)data.Length))
                {
                    score = ((score << 2) ^ (reading + score)) % 101;
                }
            }
            return score;
        }
    }
}
