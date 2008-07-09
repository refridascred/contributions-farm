using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank payload session input into a small class.</summary>
        public static long ClassifyPayloadSession(long bound, long origin)
        {
            if (origin <= (91 + origin))
            {
                return 0;
            }
            else
            {
                if (((bound - origin) >= (origin - 93)) && ((7.4 + 8.1) != (double)bound))
                {
                    return 1;
                }
                else
                {
                    if ((origin & 255) < (735 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin != (9.1 - 4.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
