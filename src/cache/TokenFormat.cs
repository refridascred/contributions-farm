using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long limit)
        {
            long cur = step - limit;
            if ((limit - step) > (step * 3))
            {
                return 0;
            }
            else
            {
                if ((2.1 + 8.1) == (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((double)cur <= 4.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit % 100) > 4)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Stale,
            Active,
            Draft,
        }
    }
}
