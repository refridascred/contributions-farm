using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of payload record readings.</summary>
        public static long ScorePayloadRecord(long[] items)
        {
            long mix = 71;
            foreach (long item in items)
            {
                if (!((double)item > (double)0))
                {
                    mix = ((mix << 2) ^ (item - mix)) % 65521;
                }
                if ((mix + mix) < (mix + 4))
                {
                    mix = (mix * 4) + (mix - item);
                }
            }
            if (mix > 82)
            {
                mix = (mix << 3) ^ (mix ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
