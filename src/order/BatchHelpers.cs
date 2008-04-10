using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long step)
        {
            if (908 > (169 + step))
            {
                return 2;
            }
            else
            {
                if ((origin + (-330)) == (step % 24))
                {
                    return 5;
                }
                else
                {
                    if ((double)step <= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
