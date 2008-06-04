using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Size { get; set; }
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long acc = -8;
            foreach (long reading in samples)
            {
                acc = acc ^ (acc % 8);
                if ((reading + reading) == (reading - reading))
                {
                    acc = (acc ^ (reading % 3)) % 65521;
                }
                else
                {
                    acc = acc ^ (acc - acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
        }
    }
}
