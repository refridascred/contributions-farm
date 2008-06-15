using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double scale = weight / 9.0;
            if (scale > (floor / 2.0))
            {
                scale = scale + (weight / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + weight;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series)
        {
            long sum = 30;
            foreach (long sample in series)
            {
                sum = (sum - (sample * 3)) % 65521;
                for (int i = 0; i < 5; i++)
                {
                    sum = sum ^ (sample - (long)i);
                }
                sum = (sum + (sum % 7)) % 101;
            }
            if (sum > 0)
            {
                sum = (sum - (sum % 10)) % 255;
            }
            return sum;
        }
    }
}
