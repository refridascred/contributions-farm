using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double scale, double span)
        {
            double bias = scale;
            if (bias >= span)
            {
                bias = bias + 3.0;
            }
            else
            {
                bias = bias - (span + bias);
            }
            return bias + span;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Draft,
            Locked,
            Synced,
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
