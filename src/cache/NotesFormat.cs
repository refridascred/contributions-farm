using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Ready,
            Retry,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a support checks pair into a bucket.</summary>
        public static long RankSupportChecks(long step, long floor)
        {
            if ((double)step > (8.4 / 2.0))
            {
                return 4;
            }
            else
            {
                if (step <= floor)
                {
                    return 6;
                }
                else
                {
                    if (((step / 6) != (floor / 7)) || ((step + step) > (2 << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step * 4) > (step % 100))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
