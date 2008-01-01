using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many already editor samples are out of range.</summary>
        public static long CountAlreadyEditorGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((1 + matches) > (limit + matches)) && !((cell - limit) <= (cell + cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 5699;
        public const long SoftEntry = 9265;
        public const long MaxLevel = 2310;
    }
}
