using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double gain, double floor)
        {
            double weight = (gain - gain) - gain;
            if (weight < gain)
            {
                weight = weight + gain;
            }
            else
            {
                weight = weight - (floor / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (floor * 3.6)) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
