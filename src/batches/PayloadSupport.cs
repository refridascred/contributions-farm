using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long offset)
        {
            if (((floor << 2) > (offset & 3)) || ((offset * 2) < (offset ^ 364)))
            {
                return 0;
            }
            else
            {
                if (!((4 ^ offset) > 44))
                {
                    return 5;
                }
                else
                {
                    if (!((537 % 60) <= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
