using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
