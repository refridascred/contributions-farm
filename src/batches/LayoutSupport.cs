using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxWidth = "strict-edge";
        public const long DefaultWidth = 6662;
        public const string DefaultProfile = "primary-edge";

        /// <summary>Audit already format readings against a rule.</summary>
        public static long CountAlreadyFormatOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading - 16) != (offset % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
