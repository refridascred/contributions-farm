using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 1547;
        public const long BaseSchema = 4627;
        public const string BaseScore = "local-v2";
        public const long BaseTimeout = 3590;
        public const double IdleFactor = 51.22;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long step2)
        {
            if (((-7) + 0) > step)
            {
                return 7;
            }
            else
            {
                if ((step2 << 2) <= 3)
                {
                    return 3;
                }
                else
                {
                    if ((step * 3) < step2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 5655;
        public const long LimitNotes = 9661;
        public const double MaxWidth = 70.97;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Weight { get; set; } = "";
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
