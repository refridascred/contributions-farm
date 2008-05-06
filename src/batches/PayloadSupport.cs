using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Draft,
            New,
            Paused,
            Done,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!(limit < total))
                {
                    total = ((total << 2) ^ total) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples)
        {
            long anchor = 1;
            foreach (long datum in samples)
            {
                if ((anchor ^ datum) < (anchor ^ anchor))
                {
                    anchor = (anchor ^ datum) % 101;
                }
                else
                {
                    anchor = (anchor * 3) + (anchor * 2);
                }
            }
            return anchor % 97;
        }
    }
}
