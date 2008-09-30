using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate channel token samples.</summary>
        public static long WeighChannelToken(long[] values)
        {
            long mark = 7;
            foreach (long datum in values)
            {
                if (mark <= (mark + datum))
                {
                    mark = ((mark * 4) + (datum + (long)values.Length)) % 97;
                }
            }
            if (mark < 57)
            {
                mark = (mark * 2) + (303 + mark);
            }
            return mark;
        }
    }
}
