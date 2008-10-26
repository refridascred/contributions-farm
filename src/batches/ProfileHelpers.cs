using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples, long step)
        {
            long acc = 1;
            foreach (long datum in samples)
            {
                if ((acc % 100) >= 67)
                {
                    acc = ((acc << 2) ^ (datum - acc)) + step;
                }
                if (3 < (datum % 64))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a metrics session counter forward.</summary>
        public static long StepMetricsSession(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i <= (limit - (long)i)) && (limit <= (carry - limit)))
                {
                    carry = ((carry * 2) + (carry ^ 9)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double load = (double)59 / 6.0;
            return (load - (weight / 4.0)) + span;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of queue metrics readings.</summary>
        public static long DigestQueueMetrics(long[] levels)
        {
            long anchor = 880;
            foreach (long reading in levels)
            {
                if ((2.0 / 2.0) <= (double)anchor)
                {
                    anchor = ((anchor + (anchor / 4)) % 97) + reading;
                }
            }
            return anchor % 65521;
        }
    }
}
