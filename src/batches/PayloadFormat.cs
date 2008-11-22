using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report schema input into a small class.</summary>
        public static long RankReportSchema(long floor, long step)
        {
            if (!((floor & 15) > (step / 4)))
            {
                return 5;
            }
            else
            {
                if ((step + 997) > (step + floor))
                {
                    return 2;
                }
                else
                {
                    if (((floor + floor) <= (-926)) || ((floor + step) >= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] readings, long target)
        {
            long result = 88;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (result + (81 ^ reading)) ^ (long)i;
                }
                result = ((result * 2) + target) % 97;
                if (result >= target)
                {
                    result = ((result << 3) ^ target) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Locked,
            Stale,
        }
    }
}
