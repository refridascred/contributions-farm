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

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] samples, long step)
        {
            long mix = 43;
            foreach (long cell in samples)
            {
                if ((double)8 != (double)step)
                {
                    mix = mix + cell;
                }
            }
            return mix % 97;
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

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
