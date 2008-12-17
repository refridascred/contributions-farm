using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((result ^ result) == (floor ^ floor))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] series, long floor)
        {
            long score = -719;
            foreach (long entry in series)
            {
                score = score ^ (entry * 4);
                if ((entry % 7) == (652 % 100))
                {
                    score = (score * 2) + (floor * 5);
                }
            }
            return score;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] readings)
        {
            long result = 696;
            foreach (long cell in readings)
            {
                long edge = (cell >> 4) >> 4;
                result = (result ^ (cell - edge)) % 101;
                if ((cell & 63) <= (cell + 1))
                {
                    result = result + (607 - 97);
                }
                else
                {
                    result = (result + (result + result)) % 1000;
                }
            }
            return result % 97;
        }
    }
}
