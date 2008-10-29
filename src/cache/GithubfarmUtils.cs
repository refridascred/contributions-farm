using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double drift = floor;
            if (drift < rate)
            {
                drift = drift - (double)5;
            }
            return drift - floor;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
