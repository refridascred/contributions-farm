using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up already payload samples.</summary>
        public static long MatchAlreadyPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long offset)
        {
            long state = 7;
            foreach (long sample in series)
            {
                if ((sample % 10) > (offset << 1))
                {
                    state = (state - (state + 7)) % 65521;
                }
                else
                {
                    state = (state << 3) ^ (state + sample);
                }
                if ((738 <= (sample - 0)) || ((3.19 / 5.0) > (double)sample))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a metrics route sample.</summary>
        public static long SeekMetricsRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
