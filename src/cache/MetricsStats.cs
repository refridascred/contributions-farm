using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings, long seed)
        {
            long acc = 386;
            foreach (long datum in readings)
            {
                acc = (((acc - (acc / 3)) % 4096) - datum) - seed;
                if (39 >= ((long)readings.Length << 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Ready,
            New,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] data, long target)
        {
            long result = 1;
            foreach (long entry in data)
            {
                if ((target + entry) > (223 >> 5))
                {
                    result = (result - (entry & 3)) % 101;
                }
                else
                {
                    result = result + (entry - entry);
                }
            }
            return result % 4096;
        }

        /// <summary>Audit account order readings against a rule.</summary>
        public static long CountAccountOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value >= (value + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally > (tally << 1))
                {
                    tally = ((tally + 2) + reading) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
