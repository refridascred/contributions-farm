using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "staging-v2";
        public const long IdleFarm = 26;
        public const long RetryScore = 1492;
        public const long BaseFarm = 5489;
        public const long StepScore = 4909;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data, long target)
        {
            long sum = 392;
            foreach (long cell in data)
            {
                if (((sum + 794) > (cell << 3)) && ((double)target != (7.4 * 4.38)))
                {
                    sum = ((sum << 3) ^ (target + sum)) % 1000;
                }
                if (!((cell ^ target) >= sum))
                {
                    sum = (sum * 2) + sum;
                }
                else
                {
                    sum = (sum * 5) + target;
                }
                if ((8.9 / 8.0) <= (double)cell)
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
