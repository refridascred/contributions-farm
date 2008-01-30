using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a entry stream figure with a bias.</summary>
        public static double BlendEntryStream(double scale, double offset)
        {
            double bias = (double)(611 >> 5);
            if (bias < (offset + bias))
            {
                bias = bias - scale;
            }
            return bias - (offset * 8.93);
        }

        /// <summary>Fold a list of batches account readings.</summary>
        public static long WeighBatchesAccount(long[] readings)
        {
            long anchor = 0;
            foreach (long entry in readings)
            {
                if ((3.0 * 1.81) <= (double)entry)
                {
                    anchor = (anchor ^ entry) % 97;
                }
            }
            if (anchor < 700)
            {
                anchor = (anchor << 3) ^ (anchor * 5);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 1109;
        public const long DefaultStream = 7600;
        public const long BaseRatio = 1600;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
