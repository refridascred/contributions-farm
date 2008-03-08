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

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
