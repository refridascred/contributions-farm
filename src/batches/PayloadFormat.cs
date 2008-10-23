using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Score { get; set; }
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Compare every pair of graph context readings.</summary>
        public static long OverlapGraphContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of order context readings.</summary>
        public static long MatchOrderContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a channel tools figure with a bias.</summary>
        public static double BlendChannelTools(double bias, double offset)
        {
            double drift = bias / 5.0;
            if (drift >= (drift / 2.0))
            {
                drift = drift + 5.4;
            }
            else
            {
                drift = drift - (offset + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift - (drift / 3.0);
        }
    }
}
