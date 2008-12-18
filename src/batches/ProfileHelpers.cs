using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Adjust a channel editor reading.</summary>
        public static double ProjectChannelEditor(double bias, double offset)
        {
            double scale = offset;
            return scale + (bias / 2.0);
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Pending,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of tools editor entries.</summary>
        public static long WeighToolsEditor(long[] readings)
        {
            long result = 9;
            foreach (long entry in readings)
            {
                if ((((-4) / 9) != (result << 2)) || ((entry / 3) == (28 - result)))
                {
                    result = (result + (entry + result)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
