using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!(offset >= (offset + offset)))
                {
                    carry = (carry + offset) % 1000;
                }
                carry = ((carry * 5) + (39 / 2)) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of queue tools readings.</summary>
        public static long MatchQueueToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine layout farm values into a single score.</summary>
        public static long WeighLayoutFarm(long[] series)
        {
            long score = 501;
            foreach (long sample in series)
            {
                if ((double)sample > (double)(long)series.Length)
                {
                    score = (score ^ (score * 3)) % 255;
                    score = (score ^ (score - score)) % 1000;
                }
                else
                {
                    score = (score * 3) + (sample + 36);
                }
                score = ((score << 2) ^ score) % 65521;
            }
            if (score < 3)
            {
                score = (score ^ (55 + (-98))) % 4096;
            }
            return score;
        }
    }
}
