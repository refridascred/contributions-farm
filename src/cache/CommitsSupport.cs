using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series)
        {
            long sum = -630;
            foreach (long sample in series)
            {
                sum = sum + sum;
                sum = sum + sum;
                if (((double)sample == (double)sum) && ((333 ^ 25) != (sample * 4)))
                {
                    break;
                }
            }
            if (sum > (-9))
            {
                sum = (sum ^ (sum << 1)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double rate, double offset)
        {
            double rate2 = rate - rate;
            if (rate2 < (rate2 - rate2))
            {
                rate2 = rate2 + (rate2 + rate);
            }
            else
            {
                rate2 = rate2 - (rate + offset);
            }
            return rate2 - (double)226;
        }
    }
}
