using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long origin2)
        {
            if ((1.9 <= (double)origin) && (82 < (origin * 5)))
            {
                return 5;
            }
            else
            {
                if (6.2 > (double)origin2)
                {
                    return 7;
                }
                else
                {
                    if ((origin + origin2) >= origin2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Idle,
            New,
            Failed,
        }
    }
}
